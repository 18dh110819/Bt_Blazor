namespace BtBlazor.Services;

public class WalletService
{
    public List<WalletVm> hist { get; set; } = new List<WalletVm>();

    public WalletVm modalItem { get; set; } = new WalletVm();

    public WalletService()
    {
        // Constructor
    }

    public event Action? OnChange;

    public async Task StateHasChange()
    {
        OnChange?.Invoke(); //Gọi giao diện đang kết nối với Component chủ động re-render
    }

    public async Task AddToHist(WalletVm item)
    {
        var newItem = new WalletVm
        {
            Type = item.Type,
            Amount = item.Amount,
            TransactionDate = DateTime.Now
        };
        hist.Add(newItem);

        await StateHasChange();
    }

    public async Task AdjustAmount(WalletVm item, decimal amount)
    {
        item.Amount += amount;
        if (item.Amount <= 0) item.Amount = 1;

        await StateHasChange();
    }

    public async Task ShowModal(WalletVm item, string type)
    {
        modalItem.Type = type;
        modalItem = item;

        await StateHasChange();
    }
}