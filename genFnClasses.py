from genFnClass import createCsharpFile
import sys
from os import listdir, makedirs, path
from os.path import isfile, join
from progressbar import *

# python ./genFnClasses.py $TES3MP_PATH/apps/openmw-mp/Script/Functions $OUT/lib
if __name__ == '__main__':
    cppfilesDir = sys.argv[1]
    outdir = sys.argv[2]
    hppfiles = [f for f in listdir(cppfilesDir) if isfile(join(cppfilesDir, f)) and f.endswith('.hpp')]
    if not path.exists(outdir):
        makedirs(outdir)
    for i in progressbar(range(len(hppfiles))):
        cppfile = join(cppfilesDir, hppfiles[i])
        outfile = join(outdir, hppfiles[i].split('.')[0] + '.cs')
        if hppfiles[i] == "Timer.hpp" or hppfiles[i] == "Public.hpp":
            continue
        createCsharpFile("TES3MPSharp", cppfile, outfile)
