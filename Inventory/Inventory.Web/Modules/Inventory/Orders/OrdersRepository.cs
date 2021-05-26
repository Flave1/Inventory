﻿
using MyRow = Inventory.Inventory.Entities.OrdersRow;

namespace Inventory.Inventory.Repositories
{
    using Web.Modules.Inventory.Enums;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Linq;
    using Serenity;
     

    public class OrdersRepository : BaseRepository
    {
        private static MyRow.RowFields Fld => MyRow.Fields; 

        public OrdersRepository(IRequestContext context)
            : base(context)
        { 
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {  
            return new MySaveHandler(Context).Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        { 
            return new MySaveHandler(Context).Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler(Context).Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler(Context).Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler(Context).Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> 
        {
            public MySaveHandler(IRequestContext context) : base(context) { }
            protected override void BeforeSave()
            {
                base.BeforeSave();
                if (this.IsCreate)
                {
                    if (this.Row.OrderItems.Any())
                    {
                        foreach (var orderItem in this.Row.OrderItems)
                        {
                            orderItem.OrderDate = DateTime.UtcNow;
                            orderItem.SubTotal = orderItem.Qty * orderItem.UnitPrice;
                        }
                    }
                    this.Row.OrderDate = DateTime.UtcNow;
                    this.Row.Total = this.Row.OrderItems.Sum(d => d.SubTotal);
                    this.Row.Status = (int)FulfillmentStatusEnum.Pending;

                }
            }
        }
        
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> 
        {
            public MyDeleteHandler(IRequestContext context)
                : base(context)
            {
            } 
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> 
        {
            public MyRetrieveHandler(IRequestContext context)
                : base(context)
            {
            } 
        }
        
        private class MyListHandler : ListRequestHandler<MyRow> 
        {

            public MyListHandler(IRequestContext context)
                : base(context)
            {
            } 
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);
                var userTpe = Context.User.FindFirst(d => d.Type == "UserType")?.Value;
                //if (!User.IsInRole("Admin"))
                if (User.Identity.Name != "admin")
                {
                    if (userTpe == "1" || userTpe == "2")//  Employee || Customer
                    {
                        if (userTpe == "1")//  Employee
                        {
                            query.Where(Fld.Status == "3");//  Failed
                        }
                        if (userTpe == "2")//  Customer
                        {
                            query.Where(Fld.Status == "1" && Fld.Status == "2");//  Fulfilled && Unfulfilled
                        }
                    }
                }

                //var user = User.GetUserDefinition<UserDefinition>(Serenity.Abstractions.IUserRetrieveService. UserRetriever);
            }

        }
    }
}