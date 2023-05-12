namespace TestingxUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Null(QrCodeGeneration.CreateFont(30));
            Assert.NotNull(QrCodeGeneration.GenerateQrCode());
        }
    }
}