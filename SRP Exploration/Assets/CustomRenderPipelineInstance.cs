using UnityEngine;
using UnityEngine.Rendering;

public class CustomRenderPipelineInstance : RenderPipeline
{
    public CustomRenderPipelineInstance()
    {
    }

    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        // This is where you can write custom rendering code. Customize this method to customize your SRP.
    }
}
