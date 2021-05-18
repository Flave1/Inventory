using Serenity.ComponentModel;

namespace Inventory.Inventory
{
    public partial class OrderStatusEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Inventory.Inventory.OrderStatusEditor";

        public OrderStatusEditorAttribute()
            : base(Key)
        {
        }
    }
}
