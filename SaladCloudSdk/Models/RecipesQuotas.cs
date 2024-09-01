using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

public record RecipesQuotas(
    [property: JsonPropertyName("max_created_recipe_deployments")] long MaxCreatedRecipeDeployments,
    [property: JsonPropertyName("recipe_instance_quota")] long RecipeInstanceQuota
);
