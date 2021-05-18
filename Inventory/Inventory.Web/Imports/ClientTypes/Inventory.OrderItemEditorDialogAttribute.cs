using Serenity.ComponentModel;

namespace Inventory.Inventory
{
    public partial class OrderItemEditorDialogAttribute : CustomEditorAttribute
    {
        public const string Key = "Inventory.Inventory.OrderItemEditorDialog";

        public OrderItemEditorDialogAttribute()
            : base(Key)
        {
        }
    }
}
