namespace GestureRecognizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Kinect;
    class IGesture : GestureBase 
    {
        private SkeletonPoint origin;
        public IGesture() : base(GestureType.I) { }
        protected override bool ValidateGestureStartCondition(Skeleton skeleton) 
        {
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var hipCenterPosition = skeleton.Joints[JointType.HipCenter].Position;
            if ((handRightPosition.Y > hipCenterPosition.Y) && (handRightPosition.Y < headPosition.Y) &&
                (handRightPosition.X < shoulderRightPosition.X) && (handRightPosition.X > shoulderLeftPosition.X)) 
            {
                origin = skeleton.Joints[JointType.HandRight].Position;
                return true;
            }
            return false;
        }
        protected override bool IsGestureValid(Skeleton skeleton) 
        {
            SkeletonPoint newOne = skeleton.Joints[JointType.HandRight].Position;
            if (newOne != origin) return false;
            return true;
        }
        protected override bool ValidateGestureEndCondition(Skeleton skeleton) 
        {
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var hipCenterPosition = skeleton.Joints[JointType.HipCenter].Position;
            if ((handRightPosition.Y > hipCenterPosition.Y) && (handRightPosition.Y < headPosition.Y) &&
                (handRightPosition.X < shoulderRightPosition.X) && (handRightPosition.X > shoulderLeftPosition.X))
            {
                return true;
            }
            return false;
        }
        protected override bool ValidateBaseCondition(Skeleton skeleton) 
        {
            var handRightPoisition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            var spinePosition = skeleton.Joints[JointType.Spine].Position;
            if ((handRightPoisition.Y < shoulderRightPosition.Y) &&
                 (handRightPoisition.Y > skeleton.Joints[JointType.ElbowRight].Position.Y) && (handLeftPosition.Y < spinePosition.Y))
            {
                return true;
            }
            return false;
        }
    }
}
