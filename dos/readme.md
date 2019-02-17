# DOS GOATs
These goats are to be used for DOS malware research, and are all very simple and can be easily compiled yourself without any tools.
## Compile
To easily compile these without any MASM or such tools (or you can't copy it over)

You can use the debug.exe command to create it.

debug.exe

-a

Now you need to type the code.

-rcx

250

n

name.com

w

You can change the '250' to whatever, this is the multiplier for file size. For the assembly code provided, using 250 will result in the standard 592 byte GOAT file, and is reccomended for consistancy.
