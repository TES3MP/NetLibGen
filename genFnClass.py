import os
import sys
from helper import *

Config.set_library_path('/usr/lib/llvm-6.0/lib')


def createCsharpFile(csharpNamespace: str, cppFilename: str, csharpFilename: str):
    index = Index.create()
    tu = index.parse(cppFilename)
    funcs, classes, namespaces = find_decls(tu)

    csharpFile = open(csharpFilename, "w")

    csharpFile.write('﻿using System.Runtime.InteropServices;\n\n')
    csharpFile.write('namespace {0}\n{{\n'.format(csharpNamespace))

    # csharpFile.write('    public static class {0}\n    {{\n'.format(u.spelling))
    csharpFile.write('    public static partial class {0}\n    {{\n'.format('TES3MP'))

    for c in funcs:

        if c.kind == CursorKind.FUNCTION_DECL:
            funcName = c.spelling
            funcType = convertType(c.result_type.kind)
            #csharpFile.write('        [MethodImpl(MethodImplOptions.InternalCall)]\n')
            csharpFile.write('        [DllImport("__Internal", CharSet = CharSet.Ansi)]\n')
            csharpFile.write('        public static extern {0} {1}('.format(funcType, funcName))

            args = ''
            for par in get_params(c):
                isPtr = False
                typ = par[0]
                argName = par[-1]
                if typ == TypeKind.POINTER:
                    isPtr = True
                    typ = par[1]
                argType = convertType(typ, isPtr)
                args += '{0} {1}, '.format(argType, argName)

            csharpFile.write(args[:-2] + ');\n\n')

    csharpFile.write('    }\n')
    csharpFile.write('}')
    csharpFile.close()


if __name__ == '__main__':
    if len(sys.argv) < 3:
        print(sys.argv[0], "csharp-namespace cpp-file [csharp-file]")
        sys.exit()

    namespace = sys.argv[1]
    cppfile = sys.argv[2]
    csharpfile = ''
    if len(sys.argv) == 3:
        csharpfile = cppfile.split(os.sep)[-1].split('.')[0] + '.cs'
    else:
        csharpfile = sys.argv[3]

    createCsharpFile(namespace, cppfile, csharpfile)
