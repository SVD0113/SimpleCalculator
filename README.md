# (C# 코딩) 계산기


## 개요
-C# 프로그래밍학습

-1줄소개: 사용자 키보드입력을 받아서 계산을 해주는 계산기.

-사용한플랫폼: 
    -C#, .NET Windows Forms, Visual Studio, GitHub

-사용한컨트롤:
    - Parse, Button btn = (Button)sender, Label, TextBox, ListBox, Button, PictureBox

-사용한기술과구현한기능: 
num1,2를 만들어서 입력값을 넣을 수 있게끔 하였고, 숫자 1~9까지의 버튼이 눌리면 눌린 버튼의 숫자를 확인해서 txtOutput박스에 추가하게끔 하였습니다.
이 상태에서 +를 누르면 Output에 들어간 문자를 숫자로 변환하고, Input에 표시하고 또 다음 숫자를 받기 위해서 Output을 Clear했습니다.
다음 2번째 숫자를 입력하면 num2에 저장하고 =을 누르면 (여기서도 2번째 숫자는 Parse로 문자->숫자 변환) num1와num2를 더해서 result에 넣게끔했습니다. 이후 txtInput에 최종 수식을, txtOutput에는 결과를(여기서는 반대로 결과 숫자를 문자로 변환) 표시하게끔 만들었습니다.