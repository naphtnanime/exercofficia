public static NQuaternion GetDeltaQuaternionWithDirectionVectors(NVector3 a, NVector3 b)
{
    var dot = NVector3.Dot(a, b);
    if (dot < -0.999999)
    {
        var cross = NVector3.Cross(a, b);
        if (cross.Length() < 0.000001)
        {
            cross = NVector3.Cross(NVector3.UnitY, a);
        }
        cross = NVector3.Normalize(cross);
        return NQuaternion.CreateFromAxisAngle(cross, Pi);
    }
    else if (dot > 0.999999)
    {
        return new NQuaternion(0, 0, 0, 1);
    }
    else
    {
        var xyz = NVector3.Cross(a, b);
        var w = (float)(Math.Sqrt(a.Length() * a.Length() + b.Length() * b.Length()) + dot);
        return new NQuaternion(xyz.X, xyz.Y, xyz.Z, w);
    }
}
