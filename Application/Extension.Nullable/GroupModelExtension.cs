namespace Application
{
    public static class GroupModelExtension
    {
        public static bool IsOnlineCheck(this GroupModel groupModel)
        {
            return groupModel != null && groupModel.IsOnline == true;
        }
    }
}
