
namespace GestureRecognizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Kinect;

    class PhoneGesture : GestureBase 
    {
        public PhoneGesture() : base(GestureType.Phone) { }

        protected override bool ValidateGestureStartCondition(Skeleton skeleton) 
        {
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var elbowRightPosition = skeleton.Joints[JointType.ElbowRight].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            if ((handRightPosition.Y > shoulderRightPosition.Y) && (handRightPosition.X > headPosition.X) &&
                (handRightPosition.X < elbowRightPosition.X)) return true;
            return false;
        }
        protected override bool IsGestureValid(Skeleton skeleton) 
        {
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var elbowRightPosition = skeleton.Joints[JointType.ElbowRight].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            if ((handRightPosition.Y > shoulderRightPosition.Y) && (handRightPosition.X > headPosition.X) &&
                (handRightPosition.X < elbowRightPosition.X)) return true;
            return false;
        }
        protected override bool ValidateGestureEndCondition(Skeleton skeleton) 
        {
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;
            var elbowRightPosition = skeleton.Joints[JointType.ElbowRight].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            if ((handRightPosition.Y > shoulderRightPosition.Y) && (handRightPosition.X > headPosition.X) &&
                (handRightPosition.X < elbowRightPosition.X)) return true;
            return false;
        }
        protected override bool ValidateBaseCondition(Skeleton skeleton) 
        {
            var handRightPoisition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            var spinePosition = skeleton.Joints[JointType.Spine].Position;
            if ((handRightPoisition.Y > shoulderRightPosition.Y) &&
                 (handRightPoisition.X < skeleton.Joints[JointType.ElbowRight].Position.X) && (handLeftPosition.Y < spinePosition.Y))
            {
                return true;
            }
            return false;
        }
    }
}
