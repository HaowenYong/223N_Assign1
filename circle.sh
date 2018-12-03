rm *.dll
rm *.exe

ls -l

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -out:CircleAlgorithms.dll CircleAlgorithms.cs

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:CircleAlgorithms.dll -out:DrawCircle.dll DrawCircle.cs

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:DrawCircle.dll -out:DrawCircleMain.dll DrawCircleMain.cs

mcs -r:System -r:System.Windows.Forms -r:System.Drawing -r:DrawCircle.dll -out:circle.exe DrawCircleMain.cs

./circle.exe