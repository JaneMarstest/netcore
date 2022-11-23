

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrashTestHost()
        {
            var t = new Thread(() =>
                throw new Exception("some value")
            );

            t.IsBackground = true;
            t.Start();
            t.Join();
        }
    }
}