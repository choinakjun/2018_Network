using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class CCharacterData : CData
    {
        string playerName; //플레이어의 이름 
        bool life; //캐릭터가 살아있는지 
        Int16 character; //현재 무슨 캐릭터인지  C
        Int16 level; //현재 레벨  L
        Int16 hp; //현재 hp  
        Int16 mp; //현재 mp  
        Int16 sp; //스킬 포인트 
        Int16 hpPower; //hp 회복량 
        Int16 mpPower; //mp 회복량
        Int16 gold; //현재 골드
        Int16 speed;//이동속도
        Int16 exp;//경험치
        Int16 attackPower;//공격력
        Int16 defensPower;//방어력
        Int16 criticalChance;//치명타 확률
        Int16 penetrate;//관통력
        Int16 bloodsucking;//흡혈률


        Int16 x; //캐릭터 위치 x X
        Int16 z; //캐릭터 위치 z Z
        Int16 rotate; //캐릭터 방향
        Int16 dir_x; //애니메이션을 위한 변수 x
        Int16 dir_y; //애니메이션을 위한 변수 y
        Int16 mouse_x; 
        Int16 mouse_z;


        public override void SetData(char _id, Int16 _data)
        {
            switch(_id)
            {
                case 'C': //캐릭터가 무슨 캐릭터인지
                    character = _data;
                    break;

                case 'R':  //캐릭터의 방향
                    rotate = _data;
                    break;

                case 'X':  //캐릭터의 X 위치
                    x = _data;
                    break;

                case 'Z':  //캐릭터의 Z위치
                    z = _data;
                    break;

            }
        }

        public override Int16 GetData(char _id)
        {
            Int16 data = new Int16(); //데이터를 저장해서 이 데이터를 리턴한다.

            switch (_id)
            {
                case 'C': //캐릭터가 무슨 캐릭터인지
                    data = character;
                    break;

                case 'R':  //캐릭터의 방향
                    data = rotate;
                    break;

                case 'X':  //캐릭터의 X 위치
                    data = x;
                    break;

                case 'Z':  //캐릭터의 Z위치
                    data = z;
                    break;

            }

            return data;

            
        }

    }
}
