# Software_project---Tetris
軟體工程期末project－俄羅斯方塊

## 起始畫面
  有1,2,3,4,5 五種Mode可以選擇，按Start就可開始遊戲。

## 遊戲畫面
  旁邊Next顯示的是下一個會出現的方塊，Block記錄的是累計方塊個數，Score紀錄目前累計分數（消去一排會得到10分），Level顯示的是速度（按A鍵減速S鍵加速，最多到20），用上、下、左、右方向鍵控制目前掉落的方塊移動。
    方塊疊到最高時遊戲會結束，顯示Game over! 按New Game鍵會回到起始頁面可繼續遊戲。

## mode的差別、實作方法
   使用MVC架構提供5種mode給使用者選擇，使用繼承的方式，每個mode有不同的同名副程式，以不同顏色填滿畫面中除了方塊以外的格子。還有更改lebal(Block、Score、Level)和旁邊Next的位置。
