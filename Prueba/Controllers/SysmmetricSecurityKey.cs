namespace Lab14.Controllers
{
    internal class SysmmetricSecurityKey
    {
        private byte[] bytes;

        public SysmmetricSecurityKey()
        {
        }

        public SysmmetricSecurityKey(byte[] bytes)
        {
            this.bytes = bytes;
        }
    }
}