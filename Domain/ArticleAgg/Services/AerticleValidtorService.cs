using System.Data;

namespace Domain.ArticleAgg.Services;

public class AerticleValidtorService : IAerticleValidtorService
{

    private readonly IArticleRepository _articleRepository;

    public AerticleValidtorService(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }
        
    public void CheckthatthisRecordAlreadyExisits(string title)
    {
        if(_articleRepository.Exists(title))
            throw new DuplicateNameException()
    }
}