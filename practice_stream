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
		nums.stream().reduce(0, (base, value) -> base + value);
		nums.stream().mapToInt(x -> x).sum();
		// IntStreamバージョン
		intSrm.sum();
		
		// 平均値を求める
		// 期待値: 50
		nums.stream().mapToInt(x -> x).average().getAsDouble();
		// IntStreamバージョン
		intSrm.average().getAsDouble();
		
		// 50以上の値だけ抽出
		// 期待値: { 50, 60, 70, 80, 90 }
		nums.stream().filter(x -> x > 50).collect(Collectors.toList());
		// IntStreamバージョン
		intSrm.filter(x -> x > 50).boxed().collect(Collectors.toList());
		
		// 最大値を求める
		// 期待値: 90
		nums.stream().max(Integer::compare).get();
		// IntStreamバージョン
		intSrm.max().getAsInt();
		

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
		strs.stream().anyMatch(x -> x == "orange");
		
		// 各文字列を [ ] で囲む
		// 期待値: { "[apple]", "[orange]", ..... }
		strSrm.map(s -> "[" + s + "]").collect(Collectors.toList());
		
		// 先頭が"s"で始まる文字列
		// 期待値: { "strawberry", "shiraki" }
		strSrm.filter(s -> s.startsWith("s")).collect(Collectors.toList());
		
		// 長さが4文字以下の文字列
		// 期待値: { "apple", "kiwi", "melon", "peach" }
		strSrm.filter(s -> s.length() <= 5).collect(Collectors.toList()).forEach(System.out::println);;
		
	}

}
