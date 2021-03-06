﻿using Rhisis.World.Game.Core.Systems;

namespace Rhisis.World.Systems.Follow
{
    public class FollowEventArgs : SystemEventArgs
    {
        public int TargetId { get; }

        public float Distance { get; }

        public FollowEventArgs(int targetId, float distance)
        {
            this.TargetId = targetId;
            this.Distance = distance;
        }

        public override bool CheckArguments() => this.TargetId > 0;
    }
}
