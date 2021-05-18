using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Inventory.Inventory
{
    public partial class OrderItemEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Inventory.Inventory.OrderItemEditor";

        public OrderItemEditorAttribute()
            : base(Key)
        {
        }
    }
}
