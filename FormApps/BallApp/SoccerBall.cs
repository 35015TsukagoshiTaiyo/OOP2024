using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class SoccerBall : Obj {
        Random rand = new Random(); //乱数インスタンス

        public static int Count { get; set; }

        public SoccerBall(double xp, double yp)
            : base(xp - 25, yp - 25, @"Picture\soccer_ball.png") {

            MoveX = rand.Next(-25, 25);//移動量設定
            MoveY = rand.Next(-25, 25);
            Count++;
        }
        //戻り値：０…移動OK、１…落下した、２…バーに当たった
        public override int Move(PictureBox pbBar, PictureBox pbBall) {
            int ret = 0;
            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y,
                                                           pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                                                           pbBall.Width, pbBall.Height);

            if (PosX > 750 || PosX < 0) {
                MoveX = -MoveX;
            }
            if (PosY < 0) {
                MoveY = -MoveY;
            }
            //バーに当たったか？
            if (rBar.IntersectsWith(rBall)) {
                MoveY = -MoveY;
                ret = 2;
            }
            PosX += MoveX;
            PosY += MoveY;

            //下に落下したか
            if (PosY > 500) {
                ret = 1;
            }

            return ret;
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
