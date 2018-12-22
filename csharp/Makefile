files := Instance.cs Properties/AssemblyInfo.cs $(wildcard ./Functions/*.cs) $(wildcard ./Functions.Generated/*.cs)

all: TES3MPSharp.dll

TES3MPSharp.dll: $(files)
	@mcs -out:TES3MPSharp.dll -target:library $(files)

clean:
	@rm -f TES3MPSharp.dll

.PHONY: all clean run
