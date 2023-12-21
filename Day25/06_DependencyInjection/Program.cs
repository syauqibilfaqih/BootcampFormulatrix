using Microsoft.Extensions.DependencyInjection;

void Main()
{
	IServiceCollection service = new ServiceCollection();
	service.AddTransient<IBoard, Board>();
	service.AddTransient<GameController>();
	IServiceProvider provider = service.BuildServiceProvider();
	
	GameController game = provider.GetRequiredService<GameController>();
}

class GameController {
	private IBoard _board;
	public GameController(IBoard board) {
		_board = board;
	}
}
interface IBoard { }
class Board : IBoard { }