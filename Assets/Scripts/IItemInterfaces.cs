public interface ICoin{
    
    void DestroyThisObject();
    int GetCoinScore();

}

public interface IItem{
    int GetItemID();
    void DoingItemEffect();
}