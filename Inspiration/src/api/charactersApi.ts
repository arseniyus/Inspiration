import axios from "axios";

export interface createCharacterRequest {
    name: string;
    class: string;
    level: number;
    race: string;
    background: string;
    alignment?: string | null;
    personalityTraits?: string | null;
    ideals?: string | null;
    bonds?: string | null;
    flaws?: string | null;
    age?: number | null;
    physicalDescription?: string | null;
    experiencePoints?: number | null;
}

// get all characters
export const fetchAllCharacters = async () => {
    const response = await axios.get('http://localhost:5131/characters')

    return response.data;
};

export const fetchCharacter = async (id: string) => {
    const response = await axios.get(`http://localhost:5131/characters/${id}`)

    return response.data;
};


export const createCharacter = async (newCharacter: createCharacterRequest) => {
    const response = await axios.post('http://localhost:5131/characters', newCharacter);

    return response.data;
};

export const updateCharacter = async (id: string, character: createCharacterRequest) => {
    const response = await axios.put(`http://localhost:5131/characters/${id}`, character);

    return response.data;

};
     
export const deleteCharacter = async (id: string) => {
    const response = await axios.delete(`http://localhost:5131/characters/${id}`)

    return response.data;
};
