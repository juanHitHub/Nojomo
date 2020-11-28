﻿using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace NojomoApp.Data
{
    public class ConfirmBase:ComponentBase
    {
        protected bool ShowConfirmation { get; set; }

        [Parameter]
        public string ConfirmationTitle { get; set; } = "Confirmación de borrado";

        [Parameter]
        public string ConfirmationMessage { get; set; } = "¿Estas seguro de eliminar a ";

        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }

        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
