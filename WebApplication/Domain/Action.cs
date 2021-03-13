using System;

namespace WebApplication.Domain
{
    public class Action
    {
        public Guid Id { get; }

        public Action()
        {
            Id = Guid.NewGuid();
        }
    }

    public class PageView : Action
    {
        public ActionType Type { get; }

        public PageView()
        {
            Type = ActionType.PageView;
        }
    }

    public enum ActionType
    {
        PageView,
    }
}