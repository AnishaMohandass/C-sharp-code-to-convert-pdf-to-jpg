# C-sharp-code-to-convert-pdf-to-jpg
1) Open visual studio 2017.

2) Select Visualc# -> console Application.

3) Type the console application name , then click OK.

4) To Install GroupDocs packages:
      Tools -> NuGet Package Manager -> Package Manager Console
  
5) Type the command in the Package Manager console:
      Install-Package GroupDocs.Conversion
    
6) Add the following libraries:
    using GroupDocs.Conversion.Config;
    using GroupDocs.Conversion.Handler;
    using GroupDocs.Conversion.Converter.Option;
    
7) Create two folders to store the pdf file and output images. (create those folders inside the project folder)
    -> create a new folder (Data) , in that Data folder , create a new folder (SampleFiles) and save the pdf file (sample.pdf)
    -> in that Data folder, again create a new folder (ConvertedFiles) , to store the output images.

8) Then type the c# code.

9) Finally run the code and check the ConvertedFiles folder for the converted images.
 
