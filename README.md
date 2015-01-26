# Scanner
JavaのScanner機能をC#で実装し  
プリミティブ型や文字列の構文解析機能を提供します
区切り文字はchar.IsWhiteSpaceに当てはまる文字です  
動作サンプルとしてScannerTestフォームが含まれています  

## 機能
現在、以下の機能が利用可能です  

* NextString : 次のトークンをstringとして読み込む。終端文字列まで読み込むよう指定も可能
* NextInt : 次のトークンをintとして読み込む
* NextFloat : 次のトークンをfloatとして読み込む
* NextDouble : 次のトークンをdoubleとして読み込む
* NextDecimal : 次のトークンをdecimalとして読み込む
* IsEnd : 読み込み位置が文字列の最後に到達したか

#### サンプル
##### ・ 「abc 123 -4.56」という文字列をスキャンする  

    string text = "abc 123 -4.56";
    Scanner scanner = new Scanner(text);
	
	string val1 = scanner.NextString(); // "abc"を読み込む
	int val2 = scanner.NextInt(); // 123を読み込む
	float val3 = scanner.NextFloat(); // -4.56を読み込む
