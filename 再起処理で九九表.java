public class Sample {

	public static void main(String[] args) {
		// TimesTables(行数, 列数)
		TimesTables(9, 9);
	}
	
	static int Multiply(int from, int to, int current) {
		System.out.print(String.format("%4s", current));
		return current < to ? Multiply(from, to, current + from) : -1;
	}
	
	static int TimesTables(int row, int col, int current) {
		Multiply(current, col * current, current);
		System.out.println("\n");
		return current < row ? TimesTables(row , col, ++current) : -1;
	}
	
	// デフォルト引数用のオーバーロード
	static void TimesTables(int r, int c) { TimesTables(r, c, 1); }
}
