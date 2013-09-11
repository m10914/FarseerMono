namespace FarseerMono.Dynamics
{
	/// <summary>
	/// Additional verifier for RayCastOne.
	/// If return false, then fixture discarded.
	/// </summary>
	public interface IRayCastVerifier
	{
		bool Verify(Fixture fixa, Vector2 point, Vector2 normal, float fraction);
	}
}