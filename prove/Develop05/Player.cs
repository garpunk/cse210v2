using System.Diagnostics.Contracts;

class Player {
    public void HandleInput()
    {
        if(ContractReferenceAssemblyAttribute.IsKeyDown(KeyboardKey.LEFT))
        {
            _x -= 10;
        }
}