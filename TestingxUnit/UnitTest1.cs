namespace TestingxUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.NotNull(QrCodeGeneration.CreateFont(30));
            Assert.NotNull(QrCodeGeneration.GenerateQrCode());
        }
    }
}