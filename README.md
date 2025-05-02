# **Physics Solver**
A Windows application to solve physics problems, using formulas.
The application is mainly developed for school project, but also to learn and gain experience 😊.
***
## **How to run**
To use the application, you can either download the .exe file of the latest version from the releases section (the easiest way), or compile the code yourself

## **How to compile the code**
To compile the code on your own machine, use the steps bellow.
1. Install .NET SDK (.net8.0) and Git in your machine
2. Open a new folder in which you want to place the repo
3. `git clone https://github.com/SepehrHr/PhysicsSolver.git`
4. `cd PhysicsSolver`
5.   ``` bash
     dotnet publish PhysicsSolver -c Release -r win-x86 -f net8.0-windows --self-contained false -p:PublishSingleFile=true -o "<OUTPUT-DIRECTORY>"
     ```
     (Replcae <OUTPUT-DIRECTORY> with the place you want to save the exe file)
  
5. A single exe file must be created in the directory.
