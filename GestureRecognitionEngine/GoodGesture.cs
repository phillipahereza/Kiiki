
namespace GestureRecognizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Kinect;

    public class GoodGesture : GestureBase 
    {
        public GoodGesture() : base(GestureType.Good) { }
        float startingHandDistance;
        private float currentHandDist;
        //private float ValidateDist;
        protected override bool ValidateGestureStartCondition(Skeleton skeleton)
        {
            startingHandDistance = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft],
                skeleton.Joints[JointType.HandRight]);
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            if ((shoulderLeftPosition.X < handRightPosition.X) && (startingHandDistance > 0.1f) &&
                (shoulderRightPosition.X > handRightPosition.X) && (handRightPosition.Y < headPosition.Y)) 
            {
                currentHandDist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft],
                skeleton.Joints[JointType.HandRight]);
                return true;
            }
            return false;
        }

        protected override bool IsGestureValid(Skeleton skeleton)
        {
            float ValidateDist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft],
                skeleton.Joints[JointType.HandRight]);
            if (ValidateDist >= currentHandDist) return false;
            currentHandDist = ValidateDist;
            return true;
        }

        protected override bool ValidateGestureEndCondition(Skeleton skeleton)
        {
            float Dist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft],
                skeleton.Joints[JointType.HandRight]);
            if (Dist < 0.1f) return true;
            return false;
        }

        protected override bool ValidateBaseCondition(Skeleton skeleton)
        {
            var leftHandPosition = skeleton.Joints[JointType.HandLeft].Position;
            var spinePosition = skeleton.Joints[JointType.Spine].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            if ((leftHandPosition.Y < spinePosition.Y) && (leftHandPosition.X < shoulderRightPosition.X) &&
                (leftHandPosition.X > shoulderLeftPosition.X)) 
            {
                return true;
            }
            return false;

        }
    }
}
