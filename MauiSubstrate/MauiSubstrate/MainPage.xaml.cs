using Ajuna.NetApi.Model.Extrinsics;
using HelloKusama.NetApiExt.Generated;

namespace MauiSubstrate;

public partial class MainPage : ContentPage
{
	private const string URL = "wss://kusama-rpc.polkadot.io";

    private SubstrateClientExt _client;

	public MainPage()
	{
		InitializeComponent();

		_client = new SubstrateClientExt(
			new Uri(URL), 
			ChargeTransactionPayment.Default());
    }

	private async void OnConnectClickedAsync(object sender, EventArgs e)
	{

		if (!_client.IsConnected)
		{
			await _client.ConnectAsync(CancellationToken.None);
        } 
		else
		{
            await _client.CloseAsync(CancellationToken.None);
        }

        if (_client.IsConnected)
        {
			ConnectLbl.Text = $"Connected to {URL} [" +
				$"{_client.RuntimeVersion.ImplName}." +
				$"{_client.RuntimeVersion.ImplVersion}." +
				$"{_client.RuntimeVersion.SpecName}." +
				$"{_client.RuntimeVersion.SpecVersion}." +
				$"{_client.RuntimeVersion.ImplName}]";
            ConnectBtn.Text = "Disconnect";
        }
		else
		{
            ConnectLbl.Text = $"Bye bye!";
            ConnectBtn.Text = "Connect";
        }

        SemanticScreenReader.Announce(ConnectBtn.Text);
	}
}

