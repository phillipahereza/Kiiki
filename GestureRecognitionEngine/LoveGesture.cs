
namespace GestureRecognizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Kinect;

    class LoveGesture : GestureBase 
    {
        public LoveGesture() : base(GestureType.Love) { }
        protected override bool ValidateGestureStartCondition(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var hipLeftPosition = skeleton.Joints[JointType.HipLeft].Position;
            float dist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft], skeleton.Joints[JointType.HandRight]);
            if ((handRightPosition.Y < shoulderLeftPosition.Y) && (handLeftPosition.Y < shoulderLeftPosition.Y) &&
                (dist < 0.01f)) 
            {
                return true;
            }
            return false;
        }

        protected override bool ValidateBaseCondition(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var hipLeftPosition = skeleton.Joints[JointType.HipLeft].Position;
            float dist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft], skeleton.Joints[JointType.HandRight]);
            if ((handRightPosition.Y < shoulderLeftPosition.Y) && (handLeftPosition.Y < shoulderLeftPosition.Y) &&
                (dist < 0.01f))
            {
                return true;
            }
            return false;
        }

        protected override bool IsGestureValid(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            if ((handLeftPosition.X < shoulderRightPosition.X) && (handRightPosition.X < shoulderRightPosition.X)) 
            {
                return true;
            }
            return false;
        }
        protected override bool ValidateGestureEndCondition(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var hipLeftPosition = skeleton.Joints[JointType.HipLeft].Position;
            float dist = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft], skeleton.Joints[JointType.HandRight]);
            if ((handRightPosition.Y < shoulderLeftPosition.Y) && (handLeftPosition.Y < shoulderLeftPosition.Y) &&
                (dist < 0.01f))
            {
                return true;
            }
            return false;
        }
    }
}
