using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SHOP_MODE
{
    BUYING,
    SELLING,
    OUT,

    NONE
}

namespace TextRpg001
{
    
    
    partial class GameProgram
    {

        // 상점 물건 고르기(구매 모드) , 내 물건 고르기(판매 모드) 까지만 구현.
        // 실제 구매 / 판매 아직 미구현.
        static void Shop(Player _Player, Inven<Item> _ShopInven)
        {
            Console.Clear();
            Console.WriteLine("--------상점---------");
            _ShopInven.Render();
            Console.WriteLine("---------------------");
            Console.WriteLine("--------Player-------");
            _Player.Pro_PlayerInven.Render();
            Console.WriteLine("---------------------");
            Console.WriteLine("\n상점주인 : 안녕하신가.");
            Console.ReadKey();


            // shop 내부에서 사용할 TmpMode 인수 -> 구매/판매 모드
            SHOP_MODE TmpMode = SHOP_MODE.BUYING;
            // Tmp모드를 변경하기 위한 _Input. 실제 입력키를 받는 인수.
            Inven<Item>.INVEN_INPUT _Input = Inven<Item>.INVEN_INPUT.CONTINUE;
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------상점---------");
                _ShopInven.Render();
                Console.WriteLine("---------------------");
                Console.WriteLine("--------Player-------");
                _Player.Pro_PlayerInven.Render();
                Console.WriteLine("---------------------");
                // 첫인사를 한번만 했으면 좋겠다
                // 1. 코인을 하나 넣어서 처음인지 가린다. 
                // 2 위에 말을 밖으로 복사한다. 
                // Console.WriteLine("\n상점주인 : 안녕하신가. ");
                // 둘다 비효율적인 것 같은데.. 
                switch (TmpMode)
                {
                    // 물건을 산다 -> 상점의 물건을 player가 add하고 상점의 물건을 지운다. 
                    case SHOP_MODE.BUYING:
                        Console.WriteLine("상점주인 : 그래. 뭐가 필요한가? \n");
                        Console.WriteLine("Enter : 이거 주세요.");
                        Console.WriteLine("Space : 팔 게 있는데.. ");
                        Console.WriteLine("ESC   : 안녕히.");

                        _Input = _ShopInven.Input();  
                        switch (_Input)
                        {
                            case Inven<Item>.INVEN_INPUT.CHANGE:
                                {
                                    TmpMode = SHOP_MODE.SELLING; // selling 모드 로 바꾼다. 
                                    continue;
                                }
                            case Inven<Item>.INVEN_INPUT.CONTINUE:
                                {
                                    TmpMode = SHOP_MODE.BUYING; // BUYING을 다시 넣어준다. 
                                }
                                break;
                            case Inven<Item>.INVEN_INPUT.SELECT:
                                {
                                    TmpMode = SHOP_MODE.BUYING;
                                    Inven<Item>.ExchangeItem(_Player.Pro_PlayerInven, _ShopInven, _ShopInven.GetSelectIndex());
                                }
                                break;
                            case Inven<Item>.INVEN_INPUT.OUT:
                                {
                                    TmpMode = SHOP_MODE.OUT;
                                }
                                break;
                            default:
                                break;
                        }
                        break;

                    case SHOP_MODE.SELLING:
                        Console.WriteLine("상점주인 : 무엇을 팔고싶나? \n");
                        Console.WriteLine("Enter : 이거 팔게요.");
                        Console.WriteLine("Space : 살 게 있는데.. ");
                        Console.WriteLine("ESC   : 안녕히.");
                        _Input = _Player.Pro_PlayerInven.Input();
                        switch (_Input)
                        {
                            case Inven<Item>.INVEN_INPUT.CHANGE:
                                {
                                    TmpMode = SHOP_MODE.BUYING; // selling 모드 로 바꾼다. 
                                    continue;
                                }
                            case Inven<Item>.INVEN_INPUT.CONTINUE:
                                {
                                    TmpMode = SHOP_MODE.SELLING; // BUYING을 다시 넣어준다. 
                                }
                                break;
                            case Inven<Item>.INVEN_INPUT.SELECT:
                                {
                                    TmpMode = SHOP_MODE.SELLING;
                                    Inven<Item>.ExchangeItem(_ShopInven, _Player.Pro_PlayerInven, _Player.Pro_PlayerInven.GetSelectIndex());
                                }
                                break;
                            case Inven<Item>.INVEN_INPUT.OUT:
                                {
                                    TmpMode = SHOP_MODE.OUT;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                        
                    case SHOP_MODE.OUT:
                        Console.WriteLine("상점주인 : 벌써 가나? 조심히 들어가게.\n");
                        _Player.Pro_PlayerInven.SelectIndex_Initialization();
                        _ShopInven.SelectIndex_Initialization();
                        Console.ReadKey();
                        return;
                    default:
                        break;
                }



            }
        }

    }
}
