namespace TestsProj;
using System.IO;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void DoesMyFirstApiDirectoryExist()
    {
        string projectDirectoryPath = @"../../../../MyFirstLesson";
        Assert.True(Directory.Exists(projectDirectoryPath), "The file directory \"MyFirstLesson\" does not exist at the root of this GitHub repository");
    }

    [Fact]
    public void DoesProgramFileInMyFirstApiExist()
    {
        string programFilePath = @"../../../../MyFirstLesson/Program.cs";
        Assert.True(File.Exists(programFilePath), "Program.cs does not exist within the \"MyFirstLesson\" directory at the root of this GitHub repository");
    }

    [Fact]
    public void DoesMyFirstLessonCsprojFileExistWithNETSDKTag()
    {
        string csprojFilePath = @"../../../../MyFirstLesson/MyFirstLesson.csproj";
        Assert.True(File.Exists(csprojFilePath), "MyFirstLesson.csproj does not exist within the \"MyFirstLesson\" directory at the root of this GitHub repository");
        string csprojContent = File.ReadAllText(csprojFilePath);
        Assert.True(csprojContent.Contains("<Project Sdk=\"Microsoft.NET.Sdk.Web\">"), "MyFirstLesson.csproj does not contain the correct tags for a .NET \"webapi\" template project");
    }
}