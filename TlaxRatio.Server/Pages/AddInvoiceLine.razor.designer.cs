﻿using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using TlaxRatio.Models.RatioModels;

namespace TlaxRatio.Server.Pages
{
    public partial class AddInvoiceLineComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected RatioDataService SimpleInvoice { get; set; }

        [Parameter]
        public dynamic InvoiceId { get; set; }

        IEnumerable<Invoice> _getInvoicesForInvoiceIdResult;
        protected IEnumerable<Invoice> getInvoicesForInvoiceIdResult
        {
            get
            {
                return _getInvoicesForInvoiceIdResult;
            }
            set
            {
                if (!object.Equals(_getInvoicesForInvoiceIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getInvoicesForInvoiceIdResult", NewValue = value, OldValue = _getInvoicesForInvoiceIdResult };
                    _getInvoicesForInvoiceIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Product> _getProductsForProductIdResult;
        protected IEnumerable<Product> getProductsForProductIdResult
        {
            get
            {
                return _getProductsForProductIdResult;
            }
            set
            {
                if (!object.Equals(_getProductsForProductIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getProductsForProductIdResult", NewValue = value, OldValue = _getProductsForProductIdResult };
                    _getProductsForProductIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        InvoiceLine _invoiceline;
        protected InvoiceLine invoiceline
        {
            get
            {
                return _invoiceline;
            }
            set
            {
                if (!object.Equals(_invoiceline, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "invoiceline", NewValue = value, OldValue = _invoiceline };
                    _invoiceline = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Security.InitializeAsync(AuthenticationStateProvider);
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var simpleInvoiceGetInvoicesResult = await SimpleInvoice.GetInvoices();
            getInvoicesForInvoiceIdResult = simpleInvoiceGetInvoicesResult;

            var simpleInvoiceGetProductsResult = await SimpleInvoice.GetProducts();
            getProductsForProductIdResult = simpleInvoiceGetProductsResult;

            invoiceline = new InvoiceLine(){};

            await InitObject(invoiceline);
        }

        protected async System.Threading.Tasks.Task Form0Submit(InvoiceLine args)
        {
            try
            {
                var processSubmitResult = await ProcessSubmit(invoiceline);
                DialogService.Close(invoiceline);
            }
            catch (System.Exception processSubmitException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to add new item!" });
            }
        }

        protected async System.Threading.Tasks.Task ProductIdChange(dynamic args)
        {
            await SelectedProduct(args,invoiceline);
        }

        protected async System.Threading.Tasks.Task QtyChange(double args)
        {
            await ChangeQty(args,invoiceline);
        }

        protected async System.Threading.Tasks.Task UnitPriceChange(double args)
        {
            await ChangePrice(args,invoiceline);
        }

        protected async System.Threading.Tasks.Task BtnCancelClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
