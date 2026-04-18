using Microsoft.JSInterop;
using Microsoft.Xna.Framework;

namespace SmallTown.Pages;

public partial class Index
{
    Game? game;

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        if (firstRender)
        {
            JsRuntime.InvokeAsync<object>("initRenderJS", DotNetObjectReference.Create(this));
        }
    }

    [JSInvokable]
    public void TickDotNet()
    {
        // init game
        if (game == null)
        {
            game = new BlazorGame();
            game.Run();
        }

        // run gameloop
        game.Tick();
    }

}
