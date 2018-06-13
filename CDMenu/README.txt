ABOUT
CDMenu is a file browser/program launcher for computers in Hamilton Library. 
We currently use this program on Asia_Stations 1-5 to let patrons browse Asia department¡¦s electronic resources.

TODO
- Add auto-generation (this method should probably go under Program.cs)
	- If there is no menu.menu file, create one.
	- Generate a README.txt if one doesn't exist.

- Add hidden shortcut to open folder-of-item
	See "Open Menu" under CDMenuWindow.Designer as an example

- Add further code documentation

BUGS
- Fullscreen Error:
	Windows Key + Up Arrow still fullscreens the program, messing up its layout.
	Possible solutions are to either prevent this or modify window elements to scale. 

- Incorrect Error Message:
	CDMenu throws "file not found" error upon launching an empty .bat file. 
	Actual thrown exception must be different than file not found. 
	Check if try/catch statement differentiates between the two.

v2.0
- .json format


v1.6
- .menu format


v1.0
- .dns format