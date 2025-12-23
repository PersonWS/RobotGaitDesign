using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotGaitDesign
{
    internal class LegState
    {
        public LegType Type { get; set; }

        // 位置和姿态
        public Vector3 FootPosition { get; set; }        // 足端世界坐标
        public Vector3 TargetPosition { get; set; }      // 目标位置
        public LegAngles CurrentAngles { get; set; }     // 当前关节角度
        public LegAngles TargetAngles { get; set; }      // 目标关节角度

        // 步态相位信息
        public double CurrentPhase { get; set; }         // [0, 1]
        public bool IsInStance { get; set; }            // 是否在支撑相
        public bool IsInContact { get; set; }           // 是否接触地面
        public float GroundContactForce { get; set; }   // 地面接触力

        // 运动状态
        public Vector3 Velocity { get; set; }
        public Vector3 Acceleration { get; set; }

        // 性能指标
        public float Torque { get; set; }
        public float PowerConsumption { get; set; }

        // 状态标志
        public bool IsEnabled { get; set; } = true;
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }

        // 历史记录（用于分析）
        public Queue<Vector3> PositionHistory { get; set; }
        public Queue<double> PhaseHistory { get; set; }

        public LegState(LegType type)
        {
            Type = type;
            PositionHistory = new Queue<Vector3>(100);
            PhaseHistory = new Queue<double>(100);
        }

        public void UpdateHistory()
        {
            PositionHistory.Enqueue(FootPosition);
            if (PositionHistory.Count > 100)
                PositionHistory.Dequeue();

            PhaseHistory.Enqueue(CurrentPhase);
            if (PhaseHistory.Count > 100)
                PhaseHistory.Dequeue();
        }

        public Vector3 GetAveragePosition(int samples = 10)
        {
            var recentPositions = PositionHistory.TakeLast(samples);
            if (!recentPositions.Any()) return FootPosition;

            Vector3 sum = Vector3.Zero;
            foreach (var pos in recentPositions)
                sum += pos;

            return sum / recentPositions.Count();
        }
    }
}
