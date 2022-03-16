namespace Application
{

    /// <summary>
    /// Модель разговорной радиогруппы.
    /// </summary>
    public class GroupModel
    {
        #region Constants

        internal const string BROADCAST_PARAMETER = "Broadcast";

        #endregion

        #region Properties

        public string Name { get; set; }

        /// <summary>
        /// Идентификатор канала/слота/КС, к которому(ой) принадлежит группа.
        /// </summary>
        public int ChannelId { get; set; }

        /// <summary>
        /// Идентификатор сервера (под которым хранятся настройки сервера в БД), к которому принадлежит группа.
        /// </summary>
        public int ServerId { get; set; }

        /// <summary>
        /// Если false => этот экземпляр - заглушка
        /// </summary>
        public bool IsOnline { get; set; }

        /// <summary>
        /// Группа может быть активна или нет в сети CapMax (временные разговорные группы или DGNA).
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Для групп (не AllCall) в сети CapMax (возможно еще в каких-то) можно включить "Широковещательный тип вызова".
        /// </summary>
        public bool IsBroadcast { get; set; }

        #endregion

        #region Constructors

        public GroupModel()
        {
            IsOnline = true;
        }

        #endregion

        #region Methods



        #endregion
    }
}
