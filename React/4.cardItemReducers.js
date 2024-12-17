export const CART_ADD_ITEM = "cart/addItem";
export const CART_REMOVE_ITEM = "cart/removeItem";
export const CART_INCREASE_ITEM = "cart/increaseItem";

export const cardReducers = (state = [], action) => {
  switch (action.type) {
    case CART_ADD_ITEM:
      return [...state, action.payload];
    case CART_REMOVE_ITEM:
      return state.filter(
        (cardItem) => cardItem.productId !== action.payload.productId
      );

    case CART_INCREASE_ITEM:
      return state.map((cardItem) => {
        if (cardItem.productId === action.payload.productId) {
          return {
            ...cardItem,
            quantity: cardItem.quantity + action.payload.increment,
          };
        }
      });

    default:
      return state;
  }
};
