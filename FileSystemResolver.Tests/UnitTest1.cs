namespace FileSystemResolver.Tests;

public class Tests
{

    [Test]
    [TestCase(0, ".")]
    [TestCase(2, "d1/","d2/","../","d21/","./")]
    [TestCase(0, "d1/","d2/","../","../","../", "../")]
    [TestCase(2, "./", "./", "someDir/", "./", "someDir2/", "./")]
    public void FileSystemResolverTest(int expected, params string[] ops)
    {
        Assert.That(FileSystemResolver.Resolve(ops), Is.EqualTo(expected));
    }
}