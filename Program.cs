/*System.Console.WriteLine("  /|");
System.Console.WriteLine(" / |");
System.Console.WriteLine("/__|");
*/
//字串 string "冰菓好看"
//字元 char '犬' 'a'\
//整數 int 40
//浮點數 double 160.5
//布林值 bool true false

//System.Console.WriteLine(false);

/* 變數
string name = "冰菓"; 設定變數，程式需要調整的時候比較有效率修改
char animal = '犬';
int age = 21;
double height = 160;
bool is male = false;
System.Console.WriteLine("有一個人叫"＋name);
name = "犬犬"
*/

/*字串常見用法
System.Console.WriteLine("hellow \nMr.White") \n跳行
System.Console.WriteLine("hellow " + " Mr.White");
字串.toupper()
字串.tolower()
字串.contains("想要知道這雙引號裡的內容有沒有在字串")
字串[0] 字串第一位的值是什麼
字串.indexof('想要找的字元在字串的哪裡，以數字表示順序')沒有找到就是-1
字串.substring(在這字串順序之前的字元都不要了，表示已填上數字) substring(6,3)第六位開始往後數三個字元都要顯示
*/

/*算數
System.Console.WriteLine(5-3);
System.Console.WriteLine(5/2.0);結果想要有小數點，算式裡面就要有小數點
可連續，且先乘除後加減
System.Console.WriteLine(system.math.abs(-10));
System.Console.WriteLine(system.math.pow(2,3));
System.Console.WriteLine(system.math.sqrt(64));
System.Console.WriteLine(system.math.max(2,100)); answer -> 100 min -> 2
System.Console.WriteLine(system.math.round(3.4));四捨五入
*/

/*System.Console.ReadLine();
System.Console.WriteLine(); 自動跳行 不跳行 write
string name = System.Console.ReadLine();
"你好啊" ＋ name + "你今年" ＋ "age"
*/


/*double num = System.Convert.todouble(System.Console.ReadLine()); double也可以換成int*/

/*array 陣列
int[] score = {1,2,3,4,5}
System.Console.WriteLine(score[0]);print 1
score[0] = 60;
string[] phone = new string[10];
phone[0] = 0123456789;
*/

/*
bool hungry = true
if(hungry){
    System.Console.WriteLine("我就去吃飯");
}
else{
    System.Console.WriteLine("我就去睡覺");
}

int score = 100;
if(score == 100){
    System.Console.WriteLine("1000");
}
else if(score >= 80){
    System.Console.WriteLine("800");
}

&& ||(or) !(not)
bool rainy = true;
if(score == 100 && rainy){
    System.Console.WriteLine("一千元打電動");
}
else{
     System.Console.WriteLine("去跑腿買東西");
}
*/

//!!!!製作進階計算機 todouble if

/*
int num = 1;
while(num<=5){
    System.Console.WriteLine(num);
    num = num + 1; num+=1 num++
}
先做再說啦
do{
    System.Console.WriteLine(num);
    num = num + 1;
}
whlie(num<=5);
 */

//!!猜數字遊戲 whlie

/*while的一行版 -> for
for(int i = 1; i <= 5; i++){
    System.Console.WriteLine(i)
}
for迴圈用途 取得陣列裡面的值
int[] nums = {1,2,3,4,5,6,7,8,9}
for(int i=0;i < num.length; i++){
    System.Console.WriteLine(nums[i])
}
*/

/*two dimension array [row,column]
int[,]nums = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
System.Console.WriteLine(nums[0,0]);

int[,] num = new int[row,column];不確定陣列裡面的值是什麼
num[0,0] = 3;

*/























