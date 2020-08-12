package practice;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;
import java.util.stream.Stream;

// Streamを使った問題
// Streamを使って期待値を正しく出力できればOK
// 出力確認はforEach()を使ってもforでやっても何でも可
public class Main {
	
	public static void main(String[] args) {
		List<Integer> nums = new ArrayList<Integer>(Arrays.asList(
								10, 20, 30, 40, 50, 60, 70, 80, 90
							 ));
		// こっちでもOK(ただし型はIntStreamとなる)
		IntStream intSrm = Arrays.stream(new int[]{ 
							10, 20, 30, 40, 50, 60, 70, 80, 90 });
		IntStream intSrm2 = IntStream.of(10, 20, 30, 40, 50, 60, 70, 80, 90);
		
		// 合計値を求める
		// 期待値: 450
		
		// 平均値を求める
		// 期待値: 50
		
		// 50以上の値だけ抽出
		// 期待値: { 50, 60, 70, 80, 90 }
		
		// 最大値を求める
		// 期待値: 90
		

		List<String> strs = new ArrayList<String>(Arrays.asList(
								"apple", "orange", "strawberry", "kiwi", "cherry",
								"banana", "melon", "shiraki", "peach"
							 ));
		// こっちでもOK
		Stream<String> strSrm = Arrays.stream(new String[]{ 
								 "apple", "orange", "strawberry", "kiwi", "cherry",
								 "banana", "melon", "shiraki", "peach" });
		
		// "orange"が含まれていたらtrueを返す
		// 期待値: true
		
		// 各文字列を [ ] で囲む
		// 期待値: { "[apple]", "[orange]", ..... }
		
		// 先頭が"s"で始まる文字列
		// 期待値: { "strawberry", "shiraki" }
		
		// 長さが4文字以下の文字列
		// 期待値: { "apple", "kiwi", "melon", "peach" }
		
	}

}
