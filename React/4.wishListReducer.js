export const WISH_ADD_ITEM = "wish/addItem";
export const WISH_REMOVE_ITEM = "wish/removeItem";

export const wishReducers = (state = [], action) => {
  switch (action.type) {
    case WISH_ADD_ITEM:
      //speard al ready created state and create new array with action.payload
      return [...state, action.payload];
    case WISH_REMOVE_ITEM:
      return state.filter(
        (wishList) => wishList.productId !== action.payload.productId
      );

    default:
      return state;
  }
};
