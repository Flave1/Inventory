using Serenity.ComponentModel;
using System;

namespace Inventory.Inventory.Forms
{
    [FormScript("Inventory.UserType")]
    [BasedOnRow(typeof(Entities.UserTypeRow), CheckNames = true)]
    public class UserTypeForm
    {
        public String Name { get; set; }
    }
}