# **Physics Solver**
A Windows application to solve physics problems, using formulas.
The application is mainly developed for school project, but also to learn and gain experience 😊.
***
## **How to run**
To use the application, you can either download the .exe file of the latest version from the releases section (the easiest way), or compile the code yourself

## **How to compile the code**
To compile the code on your own machine, use the steps bellow.
1. Install .NET SDK (.net8.0) in your machine
2. Use `git clone https://github.com/SepehrHr/PhysicsSolver.git` in the desired location to clone the repository to your machine.
3. Open a terminal in the directory of the project.
4. Enter this command and replace `<OUTPUT-DIRECTORY>` with the directory of the folder in which you want to create the .exe file.
   
  ``` bash
  dotnet publish PhysicsSolver -c Release -r win-x86 -f net8.0-windows --self-contained false -p:PublishSingleFile=true -o "<OUTPUT-DIRECTORY>"`
  and replace
  ```
  
5. A single exe file must be created in the directory.
