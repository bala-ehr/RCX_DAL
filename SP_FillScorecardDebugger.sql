DECLARE @Items [ScoreTable]

INSERT INTO @Items (score_itemid, score_projectid, card_id, score_standard)  VALUES ('BBB5B560-7C4C-4B94-B039-8864F717826C','643AD0B9-23B4-412C-9ED2-4A108E042AA2','54e40143-3094-4376-b8f3-32760dd0727f','54BB1B0D-F88B-43F9-B933-63BECC2E7620')
INSERT INTO @Items (score_itemid, score_projectid, card_id, score_standard)  VALUES ('BBB5B560-7C4C-4B94-B039-8864F717826C','643AD0B9-23B4-412C-9ED2-4A108E042AA2','54e40143-3094-4376-b8f3-32760dd0727f','48F96AB0-B5ED-44DA-8492-66A9351244EF')

EXEC [rcsp_fillscorecard] @Items 
