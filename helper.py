from clang.cindex import *

def find_decls(tu: TranslationUnit):
    filename = tu.cursor.spelling
    funcs = []
    classes = []
    namespaces = []
    for c in tu.cursor.walk_preorder():
        loc = c.location
        if loc.file is None or loc.file.name != filename:
            continue
        elif c.kind == CursorKind.FUNCTION_DECL:
            funcs.append(c)
        elif c.kind == CursorKind.CLASS_DECL:
            classes.append(c)
        elif c.kind == CursorKind.NAMESPACE:
            namespaces.append(c)
    return funcs, classes, namespaces


def get_params(node: Cursor):
    # return [[c.type.kind, c.spelling] for c in node.get_children() if c.kind == CursorKind.PARM_DECL]
    a = []
    for c in node.get_children():
        if c.kind == CursorKind.PARM_DECL:
            t: Type = c.type
            if t.kind == TypeKind.POINTER:
                ptype = t.get_pointee()
                a.append([t.kind, ptype.kind, c.spelling])
            else:
                a.append([t.kind, c.spelling])
    return a


def convertType(typeKind: TypeKind, isPtr=False) -> str:
    if typeKind is TypeKind.VOID:
        return 'void'
    elif typeKind is TypeKind.BOOL:
        return 'bool'
    elif typeKind is TypeKind.CHAR_U or typeKind is TypeKind.UCHAR:
        return 'byte'
    elif typeKind is TypeKind.CHAR_S or typeKind is TypeKind.SCHAR:
        if isPtr:
            return 'string'
        else:
            return 'sbyte'
    elif typeKind is TypeKind.SHORT:
        return 'short'
    elif typeKind is TypeKind.USHORT:
        return 'ushort'
    elif typeKind is TypeKind.UINT:
        return 'uint'
    elif typeKind is TypeKind.INT:
        return 'int'
    elif typeKind is TypeKind.ULONG:
        return 'ulong'
    elif typeKind is TypeKind.LONG:
        return 'long'
    elif typeKind is TypeKind.FLOAT:
        return 'float'
    elif typeKind is TypeKind.DOUBLE:
        return 'double'
    else:
        return 'object'  # probably will fail