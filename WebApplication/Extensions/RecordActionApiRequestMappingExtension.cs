using System;
using WebApplication.Domain;
using WebApplication.Dtos;
using Action = WebApplication.Domain.Action;

namespace WebApplication.Extensions
{
    public static class RecordActionApiRequestMappingExtension
    {
        public static Action ToDomain(this RecordActionApiRequest recordActionApiRequest)
        {
            switch (recordActionApiRequest.Type)
            {
                case ActionType.PageView:
                    return new PageView();
                default:
                    throw new Exception();
            }
        }
    }
}