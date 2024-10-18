namespace Game
{
    public class QuestItem : Item
    {
        public string RelatedQuest { get; set; }

        public QuestItem (string name, string relatedQuest)
        : base(name)
        {
            RelatedQuest = relatedQuest;
        }
    }
}