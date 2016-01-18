
namespace GestureRecognizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Kinect;
    class SickGesture : GestureBase 
    {

        private SkeletonPoint originLeft;
        private SkeletonPoint originRight;
        public SickGesture() : base(GestureType.Sick) { }
        protected override bool ValidateGestureStartCondition(Skeleton skeleton) 
        {
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var handleftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var spinePosition = skeleton.Joints[JointType.Spine].Position;
            var hipCenterPosition = skeleton.Joints[JointType.HipCenter].Position;
            var shoulderCenterPosition = skeleton.Joints[JointType.ShoulderCenter].Position;
            float handHeadDist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandRight],
                skeleton.Joints[JointType.Head]);
            if ((handHeadDist < 0.05f) && (handRightPosition.Y > shoulderCenterPosition.Y) &&
                (handleftPosition.Y < shoulderLeftPosition.Y) && (handleftPosition.Y > hipCenterPosition.Y)) 
            {
                originLeft = skeleton.Joints[JointType.HandRight].Position;
                originRight = skeleton.Joints[JointType.HandRight].Position;
                return true;
            }
            return false;
        }
        protected override bool IsGestureValid(Skeleton skeleton)
        {
            SkeletonPoint newLeft = skeleton.Joints[JointType.HandRight].Position;
            SkeletonPoint newRight = skeleton.Joints[JointType.HandRight].Position;
            if ((originLeft != newLeft) && (originRight != newRight)) return false;
            return true;
        }
        protected override bool ValidateGestureEndCondition(Skeleton skeleton) 
        {
            var hipCenterPosition = skeleton.Joints[JointType.HipCenter].Position;
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var handleftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var spinePosition = skeleton.Joints[JointType.Spine].Position;
            var shoulderCenterPosition = skeleton.Joints[JointType.ShoulderCenter].Position;
            float handHeadDist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandRight],
                skeleton.Joints[JointType.Head]);
            if ((handHeadDist < 0.05f) && (handRightPosition.Y > shoulderCenterPosition.Y) &&
                (handleftPosition.Y < shoulderLeftPosition.Y) && (handleftPosition.Y > hipCenterPosition.Y))
            {
                return true;
            }
            return false;
        }
        protected override bool ValidateBaseCondition(Skeleton skeleton) 
        {
            var hipCenterPosition = skeleton.Joints[JointType.HipCenter].Position;
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var handleftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var spinePosition = skeleton.Joints[JointType.Spine].Position;
            var shoulderCenterPosition = skeleton.Joints[JointType.ShoulderCenter].Position;
            float handHeadDist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandRight],
                skeleton.Joints[JointType.Head]);
            if ((handHeadDist < 0.05f) && (handRightPosition.Y > shoulderCenterPosition.Y) &&
                (handleftPosition.Y < shoulderLeftPosition.Y) && (handleftPosition.Y > hipCenterPosition.Y))
            {
                return true;
            }
            return false;
        }

    }
}
