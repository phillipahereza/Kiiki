

namespace GestureRecognizer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Kinect;

    class DoctorGesture:GestureBase
    {
        private SkeletonPoint validateLeftHandPosition;
        private SkeletonPoint validateRightHandPosition;
        private SkeletonPoint startingLeftHandPostion;
        private SkeletonPoint startingRightHandPostion;
        private float handDiff;
        
        public DoctorGesture() : base(GestureType.Doctor) { }

        protected override bool ValidateGestureStartCondition(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;
            var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            var headPosition = skeleton.Joints[JointType.Head].Position;

            if ((handRightPosition.Y > shoulderRightPosition.Y) && (handLeftPosition.Y > shoulderLeftPosition.Y)) 
            {
                handDiff = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandRight],skeleton.Joints[JointType.HandLeft]);
                validateLeftHandPosition = skeleton.Joints[JointType.HandLeft].Position;
                validateRightHandPosition = skeleton.Joints[JointType.HandRight].Position;
                startingLeftHandPostion = skeleton.Joints[JointType.HandLeft].Position;
                startingRightHandPostion = skeleton.Joints[JointType.HandRight].Position;
                return true;
            }
            return false;
        }

        protected override bool IsGestureValid(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            var currentLeftHandPosition = skeleton.Joints[JointType.HandLeft].Position;
            var currentRightHandPosition = skeleton.Joints[JointType.HandRight].Position;
            handDiff = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandRight], skeleton.Joints[JointType.HandLeft]);
            if ((validateLeftHandPosition.Y < currentLeftHandPosition.Y) && (validateRightHandPosition.Y < currentRightHandPosition.Y)) 
            {
                return false;
            }
            validateRightHandPosition = currentRightHandPosition;
            validateLeftHandPosition = currentLeftHandPosition;
            return true;
        }

        protected override bool ValidateGestureEndCondition(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            double leftDist = Math.Abs(startingLeftHandPostion.Y - validateLeftHandPosition.Y);
            double rightDist = Math.Abs(startingRightHandPostion.Y - validateRightHandPosition.Y);
            handDiff = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandRight], skeleton.Joints[JointType.HandLeft]);
            //float handLeftSpineDiff = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandLeft], skeleton.Joints[JointType.Spine]);
            //float handRightSpineDiff = GestureHelper.GetJointDistance(skeleton.Joints[JointType.HandRight], skeleton.Joints[JointType.Spine]);
            if ((leftDist > 0.1) && (rightDist > 0.1) && (handDiff > 0.1f)) 
            {
                return true;
            }
            return false;
        }

        protected override bool ValidateBaseCondition(Skeleton skeleton)
        {
            //throw new NotImplementedException();
            var elbowRightPosition = skeleton.Joints[JointType.ElbowRight].Position;
            var elbowLeftPosition = skeleton.Joints[JointType.ElbowLeft].Position;
            var handRightPosition = skeleton.Joints[JointType.HandRight].Position;
            var handLeftPosition = skeleton.Joints[JointType.HandLeft].Position;
            //var shoulderLeftPosition = skeleton.Joints[JointType.ShoulderLeft].Position;
            //var shoulderRightPosition = skeleton.Joints[JointType.ShoulderRight].Position;

            if ((handRightPosition.X < elbowRightPosition.X) && (handLeftPosition.X > elbowLeftPosition.X)) 
            {
                return true;
            }
            return false;
        }
    }
}
