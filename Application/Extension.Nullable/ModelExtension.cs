namespace Application
{
    public static class ModelExtension
    {
        public static bool IsOnlineCheck(this Model model)
        {
            return model != null && model.IsOnline;
        }
    }
}
