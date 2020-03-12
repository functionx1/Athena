public class Cell {

    final static int CELL_TYPE_EMPTY = 0, CELL_TYPE_FOOD = 10, CELL_TYPE_SNAKE_NODE = 20;
    final int row, col;
    int type;

    public Cell(int row, int col) {
        this.row = row;
        this.col = col;
    }
}

public class Board {

    final int ROW_COUNT, COL_COUNT;
    Cell[][] cells;

    public Board(int rowCount, int columnCount) {
        ROW_COUNT = rowCount;
        COL_COUNT = columnCount;

        cells = new Cell[ROW_COUNT][COL_COUNT];
        for (int row = 0; row < ROW_COUNT; row++) {
            for (int column = 0; column < COL_COUNT; column++) {
                cells[row][column] = new Cell(row, column);
            }
        }
    }

    public void generateFood() {
        int row = (int) (Math.random() * ROW_COUNT);
        int column = (int) (Math.random() * COL_COUNT);

        cells[row][column].type = Cell.CELL_TYPE_FOOD;
    }
}
public class Snake {

    LinkedList<Cell> snakePartList = new LinkedList<>();
    Cell head;

    public Snake(Cell initPos) {
        head = initPos;
        snakePartList.add(head);
    }

    public void grow() {
        snakePartList.add(head);
    }

    public void move(Cell nextCell) {
        Cell tail = snakePartList.removeLast();
        tail.type = Cell.CELL_TYPE_EMPTY;

        head = nextCell;
        snakePartList.addFirst(head);
    }

    public boolean checkCrash(Cell nextCell) {
        for (Cell cell : snakePartList) {
            if (cell == nextCell) {
                return true;
            }
        }
public class Router {

    public static final int DIRECTION_NONE = 0, DIRECTION_RIGHT = 1, DIRECTION_LEFT = -1, DIRECTION_UP = 2, DIRECTION_DOWN = -2;
    private Snake snake;
    private Board board;
    private int direction;
    private boolean gameOver;

    public Router(Snake snake, Board board) {
        this.snake = snake;
        this.board = board;
    }

    public void setDirection(int direction) {
        this.direction = direction;
    }

    public void update() {
        if (!gameOver) {
            if (direction != DIRECTION_NONE) {
                Cell nextCell = getNextCell(snake.head);

                if (snake.checkCrash(nextCell)) {
                    setDirection(DIRECTION_NONE);
                    gameOver = true;
                } else {
                    snake.move(nextCell);
                    if (nextCell.type == Cell.CELL_TYPE_FOOD) {
                        snake.grow();
                        board.generateFood();
                    }
                }
            }
        }
    }

    private Cell getNextCell(Cell currentPosition) {
        int row = currentPosition.row;
        int col = currentPosition.col;

        if (direction == DIRECTION_RIGHT) {
            col++;
        } else if (direction == DIRECTION_LEFT) {
            col--;
        } else if (direction == DIRECTION_UP) {
            row--;
        } else if (direction == DIRECTION_DOWN) {
            row++;
        }

        Cell nextCell = board.cells[row][col];

        return nextCell;
    }
}

        return false;
    }
}